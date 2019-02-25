namespace University.Core.Domain
{
    /// <summary>
    /// Class to represent the status of a student (enrolled, withdrawn, graduated)
    /// </summary>
    public sealed class StudentStatus
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public bool IsEnrolled { get; set; }

    }
}