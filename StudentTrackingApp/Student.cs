using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace StudentTrackingApp
{
    [FirestoreData]
    public class Student
    {
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string Surname { get; set; }

        [FirestoreProperty]
        public int Class { get; set; }

        [FirestoreProperty]
        public int No { get; set; }

        [FirestoreProperty]
        public int Grade1 { get; set; }

        [FirestoreProperty]
        public int Grade2 { get; set; }

        [FirestoreProperty]
        public int GradeAvg { get; set; }
    }
}
