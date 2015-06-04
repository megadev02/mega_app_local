using System;
using Mega.Bdo;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;

namespace Mega.App
{    
    public delegate void MsgServer<in T>(T msg);

    public static class SocketConexion
    {
        static Socket _socket;
                        
        public static event MsgServer<CMsgOficina> OnMsgOficina;
        public static event MsgServer<CMsgTransferencia> OnMsgTransferencia;
        public static event MsgServer<CMsgPersona> OnMsgPersona; 

        public static void Conectar()
        {
            try
            {                
                _socket = IO.Socket(CUtil.DireccionServer);

                _socket.Connect();                               
                
                _socket.On("msgOficina", msg =>
                {                    
                    var msgOficina = JsonConvert.DeserializeObject<CMsgOficina>(msg.ToString());
                    if (OnMsgOficina != null) OnMsgOficina(msgOficina);
                });

                _socket.On("msgTransferencia", msg =>
                {
                    var msgTransferencia = JsonConvert.DeserializeObject<CMsgTransferencia>(msg.ToString());
                    if (OnMsgTransferencia != null) OnMsgTransferencia(msgTransferencia);
                });

                _socket.On("msgPersona", msg =>
                {
                    var msgPersona = JsonConvert.DeserializeObject<CMsgPersona>(msg.ToString());
                    if (OnMsgPersona != null) OnMsgPersona(msgPersona);
                });

                EnviarNombre();
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexión.", ex);
            }
        }

        public static void Enviar<TU>(TU msg)
        {
            if (_socket == null) return;

            //convertir a cadena json            
            var msgJson = JsonConvert.SerializeObject(msg, new JsonSerializerSettings {DateFormatString = "yyyy-MM-dd HH:mm:ss"});
            
            //- enviar el mensaje            
            //if (msg is CMsgTransferencia) _socket.Emit("msgTransferencia", ack =>
            //{
            //    //sacar de la cola si el mensaje es 'msgTransferenciaOk'                
            //}, msgJson);
            if (msg is CMsgTransferencia) _socket.Emit("msgTransferencia", msgJson);
            else if (msg is CMsgOficina) _socket.Emit("msgOficina", msgJson);
            else if (msg is CMsgPersona) _socket.Emit("msgPersona", msgJson);                       
            else
                throw new Exception("Procesamiento no implementado para el mensaje");
        }        

        public static void EnviarNombre()
        {
            if (_socket != null)
                _socket.Emit("nameclient", CUtil.MiBase);
        }

        public static void Desconectar()
        {
            if (_socket != null)
                _socket.Disconnect();
        }

        public static void Reconnect()
        {
            
        }
    }
}
