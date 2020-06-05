using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationASPNET_Cloud.Models;


namespace WebApplicationASPNET_Cloud.Controllers
{    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private const string _clientId = "1jqdb6durpdka49pighshsmsem";
        private readonly Amazon.RegionEndpoint _region = Amazon.RegionEndpoint.APSouth1;

        public IActionResult Login()
        {
            AccountModel model = new AccountModel("userid...","password...","....@gmail.com");

            return View(model);
        }
                
        [HttpPost]
        //public  ActionResult SignUp()
        //Task<ActionResult<string>>
        public async Task<IActionResult> SignUp()
        {
            if (ModelState.IsValid)
            {
                var cognito = new AmazonCognitoIdentityProviderClient("Access key ID", "Secret access key", _region);
                /*User Sign up (new user creation)*/
                //var request = new SignUpRequest
                //{
                //    ClientId = _clientId,
                //    Password = "...",
                //    Username = "...."
                //};

                //var emailAttribute = new AttributeType
                //{
                //    Name = "email",
                //    Value = "....@gmail.com"
                //};
                //request.UserAttributes.Add(emailAttribute);

                //var response = await cognito.SignUpAsync(request);
                /*SignUp End*/


                /*User Login*/
                var request = new AdminInitiateAuthRequest
                {
                    UserPoolId = "ap-south-1_beZvEAZjS",
                    ClientId = _clientId,
                    AuthFlow = AuthFlowType.ADMIN_USER_PASSWORD_AUTH                    

                };

                request.AuthParameters.Add("USERNAME", "....");
                request.AuthParameters.Add("PASSWORD", ".....");

                var response = await cognito.AdminInitiateAuthAsync(request);

                string id = response.AuthenticationResult.IdToken;

                /*Login End*/
                //return RedirectToAction("Index");
            }
            return View("SignUp");
        }


        public IActionResult Index(int? pageNumber)
        {
            ProductModel model = new ProductModel();
            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 4;

            List<Product> products = Product.GetSampleProducts();

            if (products != null)
            {
                model.Products = products.OrderBy(x => x.Id)
                         .Skip(model.PageSize * (model.PageNumber - 1))
                         .Take(model.PageSize).ToList();

                model.TotalCount = products.Count();
                var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = page + 1;
            }

            return View(model);

            //return View();
        }

        public IActionResult TeamListData(int? pageNumber)
        {
            TeamListAndDataModel model = new TeamListAndDataModel();
            List<TeamList> teamListData = TeamList.GetTeamsData();

            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 5;

            if (teamListData != null)
            {
                //model.TeamListData = teamListData;

                model.TeamListData = teamListData.OrderBy(x => x.PIDNumber)
                        .Skip(model.PageSize * (model.PageNumber - 1))
                        .Take(model.PageSize).ToList();

                model.TotalCount = teamListData.Count();
                var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = page + 1;

            }

            return View(model);
        }

        
        public IActionResult TeamVacation(int? pageNumber)
        {
            VacationModel model = new VacationModel();
            List<Vacations> vacationListData = Vacations.GetVacationList();

            model.PageNumber = (pageNumber == null ? 1 : Convert.ToInt32(pageNumber));
            model.PageSize = 5;

            if (vacationListData != null)
            {
                //model.TeamListData = teamListData;

                model.VacationListData = vacationListData.OrderBy(x => x.EmployeeName)
                        .Skip(model.PageSize * (model.PageNumber - 1))
                        .Take(model.PageSize).ToList();

                model.TotalCount = vacationListData.Count();
                var page = (model.TotalCount / model.PageSize) - (model.TotalCount % model.PageSize == 0 ? 1 : 0);
                model.PagerCount = page + 1;

            }

            return View(model);
        }

        public ActionResult GetProducts(string sidx, string sord, int page, int rows)
        {
            var products = Product.GetSampleProducts();
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            int totalRecords = products.Count();
            int totalPages = (int)Math.Ceiling((float)totalRecords / (float)pageSize);

            var data = products.OrderBy(x => x.Id)
                         .Skip(pageSize * (page - 1))
                         .Take(pageSize).ToList();

            var jsonData = new
            {
                total = totalPages,
                page = page,
                records = totalRecords,
                rows = data
            };

            return Json(jsonData);
        }

        public ActionResult GetProductById(int id)
        {
            var products = Product.GetSampleProducts().Where(x => x.Id == id); ;

            if (products != null)
            {
                ProductModel model = new ProductModel();

                foreach (var item in products)
                {
                    model.Name = item.Name;
                    model.Price = item.Price;
                    model.Department = item.Department;
                }

                return PartialView("_GridEditPartial", model);
            }

            return View();
        }

        [HttpPost]
        public ActionResult UpdateProduct(ProductModel model)
        {
            //update database
            return Content("Record updated!!", "text/html");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
