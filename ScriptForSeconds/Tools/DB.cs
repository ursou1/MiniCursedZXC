using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptForSeconds.Tools
{
    public class DB
    {
        public static ur_soulEntities ur_soulEntities;
        public static ur_soulEntities GetDB()
        { 
            if(ur_soulEntities ==null)
            {
                ur_soulEntities = new ur_soulEntities();
            }
            return ur_soulEntities;
        }
    }
}
