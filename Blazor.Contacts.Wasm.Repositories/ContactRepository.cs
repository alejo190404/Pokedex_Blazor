using Blazor.Contacts.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContactRepository(IDbConnection dbConnection) {
            _dbConnection = dbConnection;
        }

        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAllContacts()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
