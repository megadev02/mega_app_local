if exists (select * from dbo.sysobjects where id = object_id(N'spSearchMovFondos') and OBJECTPROPERTY(id, N'IsProcedure') = 1) drop procedure spSearchMovFondos
GO
CREATE PROCEDURE spSearchMovFondos
AS
	SELECT A.MovimientoFondosId, A.CodDocumento, A.NumeroDocumento, 
		A.OficinaIdProcedencia, A.OficinaIdDestino, 
		B.ApellidoPaterno + ' ' + B.ApellidoMaterno + ' ' + B.PrimerNombre + ' '+ B.SegundoNombre AS 'NombrePersona',
		D.Nombre As 'NombreEntidad', C.Direccion As 'DirEntidad'
	FROM MovimientoFondos A LEFT JOIN Persona B ON A.CodigoPersona = B.CodigoPersona
		LEFT JOIN Banco C ON A.BancoId = C.BancoId
		LEFT JOIN EntidadFinanciera D ON C.EntidadId = D.EntidadId
		
GO

exec spSearchMovFondos