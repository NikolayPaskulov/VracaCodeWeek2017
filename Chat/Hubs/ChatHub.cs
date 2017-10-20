using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Chat.Hubs
{
    public class ChatHub : Hub
    {
        private static ConcurrentDictionary<string, User> Users = new ConcurrentDictionary<string, User>();

        public void UserConnected(string name)
        {
            User newUser = new User()
            {
                Id = this.Context.ConnectionId,
                Name = name
            };

            this.Clients.Caller.AddUsers(Users.Select(x => x.Value));

            Users.TryAdd(this.Context.ConnectionId, newUser);

            this.Clients.Others.UserConnected(newUser);
        }

        public void Message(string msg)
        {
            User user;
            Users.TryGetValue(this.Context.ConnectionId, out user);
            this.Clients.All.Message(new {
                User = user,
                Message = msg
            });

        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var id = this.Context.ConnectionId;
            User user;
            Users.TryRemove(id, out user);

            this.Clients.All.RemoveUser(user);
            return base.OnDisconnected(stopCalled);
        }
    }

    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}