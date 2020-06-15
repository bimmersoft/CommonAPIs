﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CM_APPLICATIONS;

namespace CM_APPLICATIONS.Controllers
{
    public class COPR16_FG_MSTRController : Controller
    {
        private COPR16Entities db = new COPR16Entities();

        // GET: COPR16_FG_MSTR
        public async Task<ActionResult> Index()
        {
            //Task<List<COPR16_FG_MSTR>> model = await new Task<List<COPR16_FG_MSTR>>();
            return View(await db.COPR16_FG_MSTR.Where(l =>l.ADATE == null).ToListAsync());
            //return View();
        }

        // GET: COPR16_FG_MSTR/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            if (cOPR16_FG_MSTR == null)
            {
                return HttpNotFound();
            }
            return View(cOPR16_FG_MSTR);
        }

        // GET: COPR16_FG_MSTR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: COPR16_FG_MSTR/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FG_NO,FG_NAME,FG_DESC,ADATE,CT_BY,MOD_BY,MOD_DATE,FLGACT")] COPR16_FG_MSTR cOPR16_FG_MSTR)
        {
            if (ModelState.IsValid)
            {
                db.COPR16_FG_MSTR.Add(cOPR16_FG_MSTR);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cOPR16_FG_MSTR);
        }

        // GET: COPR16_FG_MSTR/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            if (cOPR16_FG_MSTR == null)
            {
                return HttpNotFound();
            }
            return View(cOPR16_FG_MSTR);
        }

        // POST: COPR16_FG_MSTR/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FG_NO,FG_NAME,FG_DESC,ADATE,CT_BY,MOD_BY,MOD_DATE,FLGACT")] COPR16_FG_MSTR cOPR16_FG_MSTR)
        {
            if (ModelState.IsValid)
            {
                cOPR16_FG_MSTR.MOD_BY = System.Environment.UserName.ToLower();
                cOPR16_FG_MSTR.MOD_DATE = System.DateTime.Now;
                db.Entry(cOPR16_FG_MSTR).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cOPR16_FG_MSTR);
        }

        // GET: COPR16_FG_MSTR/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            if (cOPR16_FG_MSTR == null)
            {
                return HttpNotFound();
            }
            return View(cOPR16_FG_MSTR);
        }

        // GET: COPR16_FG_MSTR/Deactive/5
        public async Task<ActionResult> Deactive(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            if (cOPR16_FG_MSTR == null)
            {
                return HttpNotFound();
            }

            cOPR16_FG_MSTR.FLGACT = false;
            cOPR16_FG_MSTR.MOD_BY = System.Environment.UserName.ToLower();
            cOPR16_FG_MSTR.MOD_DATE = System.DateTime.Now;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: COPR16_FG_MSTR/Deactive/5
        public async Task<ActionResult> Active(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            if (cOPR16_FG_MSTR == null)
            {
                return HttpNotFound();
            }

            cOPR16_FG_MSTR.FLGACT = true;
            cOPR16_FG_MSTR.MOD_BY = System.Environment.UserName.ToLower();
            cOPR16_FG_MSTR.MOD_DATE = System.DateTime.Now;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // POST: COPR16_FG_MSTR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            COPR16_FG_MSTR cOPR16_FG_MSTR = await db.COPR16_FG_MSTR.FindAsync(id);
            db.COPR16_FG_MSTR.Remove(cOPR16_FG_MSTR);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}