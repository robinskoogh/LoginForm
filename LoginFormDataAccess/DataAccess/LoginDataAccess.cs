using LoginFormDataAccess.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormDataAccess.DataAccess
{
    public class LoginDataAccess
    {
        private const string ConnectionString = "mongodb://127.0.0.1:27017";    // Local MongoDb Server
        private const string Database = "userdb_test";      // Database to connect to. Does not have to already exist, will be created when called upon first time.
        private const string UserCollection = "users";      // Document collection; users. Does not have to already exist either, same as above.
        private const string TwaatCollection = "twaats";    // Can add more collections and input them via ConnectToMongo-method

        /// <summary>
        /// Connection to Mongodb to the collection supplied. 
        /// Generic, any Model type can be added.
        /// </summary>
        /// <typeparam name="T">Collection type (Model class)</typeparam>
        /// <param name="collection">Collection of documents</param>
        /// <returns>Collection of the type specified</returns>
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(Database);
            return db.GetCollection<T>(collection);
        }

        /// <summary>
        /// Create a user that is stored on the MongoDb Server
        /// </summary>
        /// <param name="user">User to create. Can be created by instantiated a new UserModel class</param>
        /// <returns>User added to the database</returns>
        public Task CreateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            return usersCollection.InsertOneAsync(user);
        }

        public Task CreateTwaat(TwaatModel twaat)
        {
            var twaatCollection = ConnectToMongo<TwaatModel>(TwaatCollection);
            return twaatCollection.InsertOneAsync(twaat);
        }

        public async Task<List<TwaatModel>> GetAllTwaats()
        {
            var twaatCollection = ConnectToMongo<TwaatModel>(TwaatCollection);
            var results = await twaatCollection.FindAsync(_ => true);
            return results.ToList();
        }

        /// <summary>
        /// Update user record
        /// </summary>
        /// <param name="user">User to update.</param>
        /// <returns>Replaces the current user in the database with the updated user information</returns>
        public Task UpdateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
            return usersCollection.ReplaceOneAsync(filter, user);
        }

        public Task EditTwatterPost(TwaatModel twatterPost)
        {
            var twaatCollection = ConnectToMongo<TwaatModel>(TwaatCollection);
            var filter = Builders<TwaatModel>.Filter.Eq("Id", twatterPost.Id);
            return twaatCollection.ReplaceOneAsync(filter, twatterPost);
        }

        /// <summary>
        /// Tries to fetch a user with the specified user id.
        /// </summary>
        /// <param name="userId">User id used to find user</param>
        /// <returns>UserModel object (a user)</returns>
        public UserModel GetUserFromId(string userId)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Id == userId).FirstOrDefault();
            return user;
        }

        public bool UsernameIsAvailable(string username)
        {
            bool output = true;
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Username == username).FirstOrDefault();
            if (user != null)
            {
                output = false;
            }

            return output;
        }

        /// <summary>
        /// Attempts to get a user from the supplied username, while at the same time returning a bool
        /// specifying if the operation was successful or if the user returned was null
        /// </summary>
        /// <param name="username">Username used to try to find user in the database</param>
        /// <returns>UserModel object and a bool specifying if user was found or if null was returned</returns>
        public (UserModel user, bool isValid) GetUserFromUsername(string username)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Username == username).FirstOrDefault();
            bool validUser = false;
            if (user != null)
            {
                validUser = true;
            }
            return (user, validUser);
        }

        /// <summary>
        /// Checks if the supplied password matches the password of the user during a login attempt.
        /// </summary>
        /// <param name="user">User to check password against.</param>
        /// <param name="password">Input password</param>
        /// <returns>If the input password matches the password of the user in the database.</returns>
        public bool ValidatePassword(UserModel user, string password)
        {
            bool output = false;

            if(user?.Password == password)  // If user is null, operation short citcuits at ? and this expression returns false.
                                            // This to prevent a null reference exception crash.
            {
                output = true;
            }

            return output;
        }


    }
}
