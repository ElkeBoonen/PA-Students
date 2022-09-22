using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Covid_OO
{
    class Hospital
    {
        public string Location { get; private set; }
        public int Capacity { get; private set; }

        private List<Patient> _patients;
        public Hospital(string location, int capacity)
        {
            Location = location;
            Capacity = capacity;
            _patients = new List<Patient>() ;
        }

        public int CountCovid()
        {
            int count = 0;
            foreach (var item in _patients)
            {
                if (item.Covid == true) count++;
            }
            return count;
        }

        public bool AddPatient(Patient patient)
        {
            if (_patients.Count < Capacity)
            {
                //if (!patient.Covid) _patients.Add(patient);
                if (patient.Covid == false)
                {
                    _patients.Add(patient);
                    return true;
                }
                else
                {
                    if (CountCovid() < Capacity * 0.2) //20% covid
                    {
                        _patients.Add(patient);
                        return true;
                    }
                    else return false;
                }
            }
            return false;
        }

        public void RemovePatient(Patient patient)
        {
            _patients.Remove(patient);
        }

        public override string ToString()
        {
            string s = $"HOSPITAL {Location} - {Capacity} beds\n";
            foreach (var item in _patients)
            {
                s += $"  * {item}\n";
            }
            return s;
        }
    }
}
