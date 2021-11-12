using System.Net;
using System.Web.Mvc;
using Aplicação.Interfaces;
using Domain.Entities;

namespace DDDProject
{
    public class ProdutoController : Controller
    {
        private readonly IAppProduto _appProduto;
        private readonly IAppCliente _appCliente;

        public ProdutoController(IAppProduto appProduto, IAppCliente appCliente)
        {
            _appProduto = appProduto;
            _appCliente = appCliente;
        }

        // GET: Produto
        public ActionResult Index()
        {
            return View(_appProduto.GetAll());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto Produto = _appProduto.GetById(id);
            if (Produto == null)
            {
                return HttpNotFound();
            }
            return View(Produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_appCliente.GetAll(), "ClienteId", "Nome");
            return View();
        }

        // POST: Produto/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Valor,Disponivel,ClienteId")] Produto Produto)
        {
            if (ModelState.IsValid)
            {
                _appProduto.Add(Produto);
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_appCliente.GetAll(), "ClienteId", "Nome", Produto.ClienteId);
            return View(Produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto Produto = _appProduto.GetById(id);
            if (Produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(_appCliente.GetAll(), "ClienteId", "Nome");
            return View(Produto);
        }

        // POST: Produto/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutoId,Nome,Valor,Disponivel,ClienteId")] Produto Produto)
        {
            if (ModelState.IsValid)
            {
                _appProduto.Update(Produto);
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_appCliente.GetAll(), "ClienteId", "Nome");
            return View(Produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto Produto = _appProduto.GetById(id);
            if (Produto == null)
            {
                return HttpNotFound();
            }
            return View(Produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto Produto = _appProduto.GetById(id);
            _appProduto.Remove(Produto);
            return RedirectToAction("Index");
        }

    }
}
