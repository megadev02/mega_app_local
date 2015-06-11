using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Mega.Dao;
using Mega.Bdo;

namespace Mega.Logic
{
    public partial class PersonaLogic
    {
        public DataTable GetSearchPersona()
        {
            return _dataObject.GetSearchPersona();
        }
    }
}
