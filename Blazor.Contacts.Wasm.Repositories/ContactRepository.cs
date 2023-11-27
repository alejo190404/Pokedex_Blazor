﻿using Blazor.Contacts.Wasm.Shared;
using Dapper;
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

        public async Task<Contact> GetDetails(int id)
        {
            var sql = @"SELECT Id, FirstName, LastName, Phone, Address
                        FROM Contacts
                        WHERE Id = @Id";
            return await _dbConnection.QueryFirstOrDefaultAsync<Contact>(
                sql, new { Id = id}
                );
        }

        public async Task<bool> InsertContact(Contact contact)
        {
            try
            {
                var sql = @"INSERT INTO Contacts(FirstName, LastName, Phone, Address)
                            VALUES(@FirstName, @LastName, @Phone, @Address)";
                var result = await _dbConnection.ExecuteAsync(sql,
                    new
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address
                    });

                return result > 0;
            }
            catch (Exception e) {
                throw e;
            }

        }

        public async    Task<bool> UpdateContact(Contact contact)
        {
            try
            {
                var sql = @"UPDATE Contacts
                               SET FirstName = @FirstName,
                                   LastName = @LastName,
                                   Phone = @Phone,
                                   Address = @Address
                             WHERE Id = @Id";
                var result = await _dbConnection.ExecuteAsync(sql,
                    new
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address,
                        contact.Id
                    });

                return result > 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
