using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Assignment_10.Filters;
using Assignment_10.Models;
using Assignment_10.Services;

namespace Assignment_10.Controllers {

    [Route("[controller]")]
    public class GladosController : Controller {

        private ISecurityProvider securityProvider;

        private AuthorizationFilter filter = new AuthorizationFilter();

        private UsersModel users = new UsersModel();

        public GladosController(ISecurityProvider securityProvider) {
            this.securityProvider = securityProvider;
            PopulateDefaultUsers();
        }

        private void PopulateDefaultUsers() {
            UserModel model1 = new UserModel();
            UserModel model2 = new UserModel();
            model1.Username = "Glados";
            model1.Password = "Cake";
            model2.Username = "Tyler";
            model2.Password = "Test";
            users.Add(model1);
            users.Add(model2);
        }

        [HttpGet]
        public IEnumerable<UserModel> Get() {
            return users.GetAll();
        }
        
        /*
        // GET: glados
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET glados/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST glados
        [HttpPost]
        public void Post([FromBody]string value) {
            // TODO
        }

        // PUT glados/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value) {
            // TODO
        }

        // DELETE glados/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            // TODO
        }
        */

    }
}
