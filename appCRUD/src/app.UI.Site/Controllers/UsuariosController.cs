using System;
using System.Net;
using System.Web.Mvc;
using app.Aplicacao.Interfaces;
using app.Aplicacao.Serviços;
using app.Aplicacao.ViewModels;

namespace app.UI.Site.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppServico _usuarioAppServico;

        public UsuariosController()
        {
            _usuarioAppServico = new UsuarioAppServico();
        }
        
        public ActionResult Index()
        {
            return View(_usuarioAppServico.ObterAtivos());
        }

        
        public ActionResult Details(Guid? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuarioVW = _usuarioAppServico.ObterPorId(id.Value);
            if (usuarioVW == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVW);
        }

        
        public ActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioEnderecoVM usuarioEnderecoVM)
        {
            if (ModelState.IsValid)
            {
                _usuarioAppServico.Adicionar(usuarioEnderecoVM);
                return RedirectToAction("Index");
            }

            return View(usuarioEnderecoVM);
        }

       
        public ActionResult Edit(Guid? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuarioVW = _usuarioAppServico.ObterPorId(id.Value);

            if (usuarioVW == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVW);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioVW usuarioVM)
        {
            if (ModelState.IsValid)
            {
                _usuarioAppServico.Atualizar(usuarioVM);
                return RedirectToAction("Index");
            }
            return View(usuarioVM);
        }

       
        public ActionResult Delete(Guid? id)
        {
            if (id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuarioVW = _usuarioAppServico.ObterPorId(id.Value);
            if (usuarioVW == null)
            {
                return HttpNotFound();
            }
            return View(usuarioVW);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _usuarioAppServico.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _usuarioAppServico.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
