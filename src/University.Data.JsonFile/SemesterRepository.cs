using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.JsonFile
{
    public class SemesterRepository : ISemesterRepository
    {

        public SemesterRepository(String dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        private String _dataDirectory;





        public List<Semester> LoadSemesters()
        {
            FileDataObject fdo = new FileDataObject(_dataDirectory);
            return fdo.ReadSemestersFile();
        }

    }
}
