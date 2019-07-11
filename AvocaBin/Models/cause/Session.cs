using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvocaBin.Models.cause
{
    class Session
    {
        private DateTime date_session;
        private string id_cause;
        private string decision;
        public DateTime Date_session
        {
            get
            {
                return date_session;
            }

            set
            {
                date_session = value;
            }
        }

        public string Id_cause
        {
            get
            {
                return id_cause;
            }

            set
            {
                id_cause = value;
            }
        }

        public string Decision
        {
            get
            {
                return decision;
            }

            set
            {
                decision = value;
            }
        }
    }
}
