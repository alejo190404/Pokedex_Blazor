using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Shared
{
    public class Contact
    {
        private int id {  get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Phone {  get; set; }
        private string Address { get; set; }
        private String FullName { get
            {
                return LastName + ", " + FirstName;
            } }
}
