using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega.Bdo.Modules;
using Mega.Dao.Modules;

namespace Mega.Logic.Modules
{
    public class ModMovimientoFondosLogic
    {
        readonly ModMovimientoFondosDao _modMovimientoFondosDao = new ModMovimientoFondosDao();

        public bool Insert(ref ModMovimientoFondosBdo objecBdo, ref string message)
        {
            return _modMovimientoFondosDao.Insert(ref objecBdo, ref message);
        }

        public ModMovimientoFondosBdo GetById(int id)
        {
            return _modMovimientoFondosDao.GetById(id);
        }

        public DataTable GetSearchMovFondos()
        {
            return _modMovimientoFondosDao.GetSearchMovFondos();
        }
    }
}
