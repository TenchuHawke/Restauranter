using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RESTauranter.Models;

// Other usings

public class ReviewController : Controller {
    private RESTauranterContext _context;

    public ReviewController (RESTauranterContext context) {
        _context = context;
    }

    [HttpGet]
    [Route ("Main")]
    public IActionResult Main () {
            List<Review> AllReviews = _context.Reviews.OrderByDescending(o=>o.DateOfVisit).ToList ();
            ViewBag.AllReviews = AllReviews;
            return View ();
        }
        [HttpGetAttribute]
        [RouteAttribute ("New")]
    public IActionResult New () {
            ViewBag.AllErrors = ModelState.Values;
            return View ("AddNew");
        }
        [HttpPost]
        [RouteAttribute ("AddReview")]
    public IActionResult AddReview (Review NewReview) {
        if (ModelState.IsValid) {
            NewReview.CreatedAt = DateTime.Now;
            NewReview.UpdatedAt = DateTime.Now;
            _context.Add (NewReview);
            _context.SaveChanges();
            return RedirectToAction ("Main");
        }
        ViewBag.AllErrors = ModelState.Values;
        return View ("AddNew");
    }

}