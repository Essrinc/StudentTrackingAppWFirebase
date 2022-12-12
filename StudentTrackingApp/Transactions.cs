using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace StudentTrackingApp
{
    public class Transactions
    {
        public void SetData(FirestoreDb db, string collectionName, Dictionary<string, object> data)
        {
            CollectionReference collection = db.Collection(collectionName);
            collection.AddAsync(data);
        }

        public Task<QuerySnapshot> GetData(FirestoreDb db, string collectionName)
        {
            Query query = db.Collection(collectionName);
            return query.GetSnapshotAsync();
        }

        public void UpdateData(FirestoreDb db, string collectionName, string documentName, Dictionary<string, object> data)
        {
            DocumentReference document = db.Collection(collectionName).Document(documentName);
            document.UpdateAsync(data);
        }

        public void DeleteDocument(FirestoreDb db, string collectionName, string documentName)
        {
            DocumentReference document = db.Collection(collectionName).Document(documentName);
            document.DeleteAsync();
        }

        //VERDİĞİMİZ FİLTRE DEĞERİNDEN BÜYÜK OLANLARI BİZE GERİ GETİRCEK.
        public Task<QuerySnapshot> GetGreatherThan(FirestoreDb db, string collectionName, string path, int value)
        {
            Query query = db.Collection(collectionName).WhereGreaterThan(path,value);
            return query.GetSnapshotAsync();
        }

        public Task<QuerySnapshot> GetGreatherThanOrEqual(FirestoreDb db, string collectionName, string path, int value)
        {
            Query query = db.Collection(collectionName).WhereGreaterThanOrEqualTo(path, value);
            return query.GetSnapshotAsync();
        }

        public Task<QuerySnapshot> GetLessThan(FirestoreDb db, string collectionName, string path, int value)
        {
            Query query = db.Collection(collectionName).WhereLessThan(path, value);
            return query.GetSnapshotAsync();
        }

        public Task<QuerySnapshot> GetLessThanOrEqual(FirestoreDb db, string collectionName, string path, int value)
        {
            Query query = db.Collection(collectionName).WhereLessThanOrEqualTo(path, value);
            return query.GetSnapshotAsync();
        }
    }
}
