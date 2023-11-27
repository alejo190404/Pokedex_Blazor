using Blazor.Contacts.Wasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories
{
    public interface IContactRepository
    {
        //Clase abstracta de la interfaz
        Task<bool> InsertContact(Contact contact);
        Task<bool> UpdateContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetDetails(int id);

    }
}
