namespace Miguitas.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data.Repositories;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Helpers;
    using Models;
    using Miguitas.Web.Data.Entities;
    using System.Net.Http;
    using Newtonsoft.Json;

    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly IUserHelper userHelper;

        public OrdersController(
            IOrderRepository orderRepository,
            IProductRepository productRepository,
            IUserHelper userHelper)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.userHelper = userHelper;
        }

        public async Task<IActionResult> Index()
        {
            var model = await orderRepository.GetOrdersAsync(this.User.Identity.Name);
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var model = await this.orderRepository.GetDetailTempsAsync(this.User.Identity.Name);
            return this.View(model);
        }

        public IActionResult AddProduct()
        {
            var model = new AddItemViewModel
            {
                Quantity = 1,
                Products = this.productRepository.GetComboProducts()
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(AddItemViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                await this.orderRepository.AddItemToOrderAsync(model, this.User.Identity.Name);
                return this.RedirectToAction("Create");
            }

            return this.View(model);
        }

        public async Task<IActionResult> DeleteItem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await this.orderRepository.DeleteDetailTempAsync(id.Value);
            return this.RedirectToAction("Create");
        }

        public async Task<IActionResult> Increase(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await this.orderRepository.ModifyOrderDetailTempQuantityAsync(id.Value, 1);
            return this.RedirectToAction("Create");
        }

        public async Task<IActionResult> Decrease(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await this.orderRepository.ModifyOrderDetailTempQuantityAsync(id.Value, -1);
            return this.RedirectToAction("Create");
        }

        public async Task<IActionResult> ConfirmOrder()
        {
            var response = await this.orderRepository.ConfirmOrderAsync(this.User.Identity.Name);
            if (response)
            {
                return this.RedirectToAction("Index");
            }

            return this.RedirectToAction("Create");
        }

        public async Task<IActionResult> Deliver(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await this.orderRepository.GetOrdersAsync(id.Value);
            if (order == null)
            {
                return NotFound();
            }

            var model = new DeliverViewModel
            {
                Id = order.Id,
                DeliveryDate = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Deliver(DeliverViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                await this.orderRepository.DeliverOrder(model);
                return this.RedirectToAction("Index");
            }

            return this.View();
        }


        public async Task<IActionResult> DeleteOrder(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await this.orderRepository.DeleteOrderAsync(id.Value);
            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> OrderDetails(int? id)
        {
            if (id == null)
            {
                return new NotFoundViewResult("OrdersNotFound");
            }

            var orderDetails = await this.orderRepository.GetDetailsAsync(id.Value);
            if (orderDetails == null)
            {
                return new NotFoundViewResult("ProductNotFound");
            }

            return View(orderDetails);
        }

        public async Task<IActionResult> CustomerOrders(string id)
        {
            var model = await orderRepository.GetOrdersAsync(id);
            return View(model);
        }

        public async Task<IActionResult> AddToBasket(int? id)
        {
            var model = new AddItemViewModel
            {
                Quantity = 1,
                Products = this.productRepository.GetComboProducts()
            };

            if (id == null)
            {
                return new NotFoundViewResult("OrdersNotFound");
            } else if (id != null) {
                model.ProductId = id.Value;
                await this.orderRepository.AddItemToOrderAsync(model, this.User.Identity.Name);
                return this.RedirectToAction("Create");
            }

            return RedirectToAction("Index", "Products");
        }
        

        public async Task<bool> SendPostNotificacion()
        {
            HttpClient httpclient = new HttpClient();

            httpclient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpclient.DefaultRequestHeaders.Add("X-API-Token", "20aa2c75-55e7-477a-94e9-5eaff9a1b6a0");
            Object obj = new Object();

            string json = JsonConvert.SerializeObject(obj);


            return false;
        }
    }
}
