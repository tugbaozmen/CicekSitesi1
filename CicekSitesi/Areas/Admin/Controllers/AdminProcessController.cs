using CicekSitesi.Areas.Admin.Models.ViewModels;
using CicekSitesi.BLL;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSitesi.Areas.Admin.Controllers
{
    public class AdminProcessController : Controller
    {
        ProductBLL _productBLL;
        ProductTypeBLL _productTypeBLL;
        ProductTypeDetailBLL _productTypeDetailBLL;
        public AdminProcessController()
        {
            _productBLL = new ProductBLL();
            _productTypeBLL = new ProductTypeBLL();
            _productTypeDetailBLL = new ProductTypeDetailBLL();
        }

        public ActionResult CreateProduct()
        {
            GetAllProductTypeDetailToDLL();
            GetAllProductTypeToDLL();
            Product product = new Product();
            return View(product);
        }


        //TODO
        //Fotoğrafın sadece 5 karakter yazmasını yap

        [HttpPost]
        public ActionResult CreateProduct(Product model, HttpPostedFileBase image1)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.Description = model.Description;
                product.ProductName = model.ProductName;
                product.ProductTypeId = model.ProductTypeId;
                product.UnitPrice = model.UnitPrice;
                product.UnitsInStock = model.UnitsInStock;
                try
                {
                    if (image1 != null)
                    {
                        model.Photo = new byte[image1.ContentLength];
                        image1.InputStream.Read(model.Photo, 0, image1.ContentLength);
                    }
                    GetAllProductTypeDetailToDLL();
                    GetAllProductTypeToDLL();
                    _productBLL.Add(product);
                    ViewBag.IsSuccess = true;
                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.IsSuccess = false;
                    ModelState.AddModelError("", ex.Message);
                }
                return View(model);
            }
            else
            {
                ModelState.AddModelError("", "Girdiğiniz bilgileri kontrol ediniz");
            }
            return View();
        }

        private void GetAllProductTypeToDLL()
        {
            List<SelectListItem> productType = new List<SelectListItem>();
            foreach (ProductType item in _productTypeBLL.GetAll())
            {
                productType.Add(new SelectListItem { Text = item.ProductTypeName, Value = item.ProductTypeId.ToString() });
            }
            ViewBag.ProductType = productType;
        }

        private void GetAllProductTypeDetailToDLL()
        {
            List<SelectListItem> productTypeDeatil = new List<SelectListItem>();
            foreach (ProductTypeDetail item in _productTypeDetailBLL.GetAll())
            {
                productTypeDeatil.Add(new SelectListItem { Text = item.TypeDetailName, Value = item.ProductTypeDetailId.ToString() });
            }
            ViewBag.ProductTypeDetail = productTypeDeatil;
        }

        public ActionResult ListProduct()
        {
            return View(_productBLL.GetAll());
        }

        public ActionResult UpdateProduct(int id)
        {
            Product currentProduct = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                currentProduct = _productBLL.GetProduct(id);
                if (currentProduct != null)
                {
                    GetAllProductTypeDetailToDLL();
                    GetAllProductTypeToDLL();
                    return View(currentProduct);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product model)
        {
            Product product = _productBLL.GetById(model.ProductId);
            product.ProductName = model.ProductName;
            product.Description = model.Description;
            product.UnitPrice = model.UnitPrice;

            _productBLL.Update(product);
            ViewBag.Check = false;
            return RedirectToAction("ListProduct");
        }

        public ActionResult DeleteProduct(int id)
        {
            Product product = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                product = _productBLL.GetProduct(id);
                if (product != null)
                {
                    _productBLL.Delete(product);
                    return RedirectToAction("ListProduct");
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        public ActionResult ListProductType()
        {
            return View(_productTypeBLL.GetAll());
        }

        public ActionResult CreatedProductType()
        {
            GetAllProductTypeDetailToDLL();
            GetAllProductTypeToDLL();
            ProductType productType = new ProductType();
            return View(productType);
        }

        [HttpPost]
        public ActionResult CreatedProductType(ProductType model)
        {
            ProductType productType = new ProductType();
            productType.ProductTypeName = model.ProductTypeName;
            try
            {
                _productTypeBLL.Add(productType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(productType);
        }

        public ActionResult UpdateProductType(int id)
        {
            ProductType product = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                product = _productTypeBLL.GetProductType(id);
                if (product != null)
                {
                    //GetAllProductTypeDetailToDLL();
                    GetAllProductTypeToDLL();
                    return View(product);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProductType(ProductType model)
        {
            ProductType product = _productTypeBLL.GetById(model.ProductTypeId);
            product.ProductTypeName = model.ProductTypeName;

            _productTypeBLL.Update(product);
            ViewBag.Check = false;
            return RedirectToAction("ListProductType");
        }

        public ActionResult DeleteProductType(int id)
        {
            ProductType product = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                product = _productTypeBLL.GetProductType(id);
                if (product != null)
                {
                    _productTypeBLL.Delete(product);
                    return RedirectToAction("ListProductType");
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        public ActionResult ListProductTypeDetail()
        {
            return View(_productTypeDetailBLL.GetAll());
        }

        public ActionResult CreatedProductTypeDetail(ProductTypeDetail model)
        {
            ProductTypeDetail productTypeDetail = new ProductTypeDetail();
            productTypeDetail.TypeDetailName = model.TypeDetailName;
            try
            {
                _productTypeDetailBLL.Add(productTypeDetail);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(productTypeDetail);
        }

        public ActionResult UpdateProductTypeDetail(int id)
        {
            ProductTypeDetail product = null;

            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                product = _productTypeDetailBLL.GetProductTypeDetail(id);
                if (product != null)
                {
                    //GetAllProductTypeDetailToDLL();
                    GetAllProductTypeToDLL();
                    return View(product);
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProductTypeDetail(ProductTypeDetail model)
        {
            ProductTypeDetail product = _productTypeDetailBLL.GetById(model.ProductTypeDetailId);
            product.TypeDetailName = model.TypeDetailName;

            _productTypeDetailBLL.Update(product);
            ViewBag.Check = false;
            return RedirectToAction("ListProductTypeDetail");
        }

        public ActionResult DeleteProductTypeDetail(int id)
        {
            ProductTypeDetail product = null;
            if (id == null)
            {
                ViewBag.Check = false;
            }
            else
            {
                product = _productTypeDetailBLL.GetProductTypeDetail(id);
                if (product != null)
                {
                    _productTypeDetailBLL.Delete(product);
                    return RedirectToAction("ListProductTypeDetail");
                }
                else
                {
                    ViewBag.Check = true;
                }
            }
            return View();
        }
    }
}