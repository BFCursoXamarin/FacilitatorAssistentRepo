using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FacilitatorAssistentApp.Models;
using SQLite;

namespace FacilitatorAssistentApp.Models.Data
{
    public class DatabaseQuery
    {
        protected readonly SQLiteAsyncConnection _dataBase;

        public DatabaseQuery(string dbPath)
        {
            _dataBase = new SQLiteAsyncConnection(dbPath);
            _dataBase.CreateTableAsync<User>().Wait();
        }


        #region CRUDUser
                
               
        /// <summary>
        /// Get user by Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>user finded</returns>
        public Task<User> getUserIdAsync(int userId) {
            return _dataBase.Table<User>().Where(user => userId == user.idUser).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Getl all users from database
        /// </summary>
        /// <returns>List with all users</returns>
        public Task<List<User>> getUsersAsync()
        {
            return _dataBase.Table<User>().ToListAsync();
        }

        /// <summary>
        /// Method allow save a new User, if exist, only update the object User
        /// </summary>
        /// <param name="newUser">User object</param>
        /// <returns></returns>
        public Task<int> SaveUserAsync(User newUser)
        {
            return newUser.idUser != 0 ? _dataBase.UpdateAsync(newUser) : _dataBase.InsertAsync(newUser);
        }


        public Task<int> deleteUserAsync(User user) {
            return _dataBase.DeleteAsync(user);
        }

        #endregion
    }
}

