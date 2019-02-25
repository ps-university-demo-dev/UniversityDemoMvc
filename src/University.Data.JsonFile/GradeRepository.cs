using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using University.Core.DataInterface;
using University.Core.Domain;

namespace University.Data.JsonFile
{
    public class GradeRepository : IGradeRepository
    {


        public GradeRepository(String dataDirectory)
        {
            _dataDirectory = dataDirectory;
        }

        private String _dataDirectory;




        public List<Grade> LoadGrades()
        {
            FileDataObject fdo = new FileDataObject(_dataDirectory);
            return fdo.ReadGradesFile();            
        }
    }
}
