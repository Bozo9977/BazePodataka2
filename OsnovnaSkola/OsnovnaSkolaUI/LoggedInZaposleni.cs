using OsnovnaSkola;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaUI
{
    public class LoggedInZaposleni
    {
        private static ZaposleniIM instance = null;

        private LoggedInZaposleni()
        {
        }

        public static ZaposleniIM Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ZaposleniIM();
                }
                return instance;
            }
            set
            {
                if(instance == null)
                {
                    instance = value;
                }
                else
                {
                    instance = null;
                }
            }
        }
    }
}
