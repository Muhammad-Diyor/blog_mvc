// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// var menu_icon = document.querySelector(".menu_icon");
// var menu_span = document.querySelectorAll(".menu_span")

// menu_icon.addEventListener("mouseenter", function()
// {
//     menu_span.forEach(element => {
//         element.style.backgroundColor = "#6435A5";
//     });

// });
// menu_icon.addEventListener("mouseleave", function()
// {   
//     menu_span.forEach(element => {
//         element.style.backgroundColor = "black";
//     });
// }, false);

var menu_span_1 = document.querySelector(".abs");
var menu_span_2 = document.querySelector(".xyz");
var menu_span_3= document.querySelector(".aaa");
var navigation = document.querySelector(".navigation");
var logo = document.querySelector(".nav_img");
var user_nav = document.querySelector(".user_nav");

// menu_icon.addEventListener("click", function()
// {

//     if(menu_span_3.style.display == "none")
//     {
//         menu_span_1.style.transform = "none";
//         menu_span_1.style.marginTop = 3 + "px";

//         menu_span_2.style.transform = "none";
//         menu_span_2.style.marginTop = 3 + "px";

//         menu_span_3.style.display = "block";
//         navigation.style.display = "none";
//         navigation.style.marginLeft = 1000 + "px";
//         logo.style.display = "block";
//     }
//     else{
//         menu_span_1.style.transform = "rotate(42deg)";
//         menu_span_1.style.marginTop = 7 + "px";
        
//         menu_span_2.style.transform = "rotate(-42deg)";
//         menu_span_2.style.marginTop = -3 + "px";
        
//         menu_span_3.style.display = "none";
//         navigation.style.display = "block";
//         navigation.style.marginLeft = 0 + "px";
//         logo.style.display = "none";
//     }
// });

var identity_btn = document.querySelector(".identity_btn");
var identity_i = document.querySelector(".identity_btn i");

identity_btn.addEventListener("mouseenter", function()
{
    identity_i.style.paddingLeft = 10 + "px";
})

identity_btn.addEventListener("mouseleave", function()
{
    identity_i.style.paddingLeft = 0 + "px";
})

var sign_in = document.querySelector(".sign_in");
var sign_up = document.querySelector(".sign_up");
var enter_sign = document.querySelector("#enter_sign");
var open_up = document.querySelector("#open_up");
var open_in = document.querySelector("#open_in");
var blur_div = document.querySelector(".blur_div");

enter_sign.addEventListener("click", function()
{
    sign_in.style.display = "block";
    blur_div.style.display = "block";
})

open_in.addEventListener("click", function()
{
    sign_up.style.display = "none";
    sign_in.style.display = "block";
})

open_up.addEventListener("click", function()
{
    sign_in.style.display = "none";
    sign_up.style.display = "block";
})

let body = document.querySelector("body");

var blog_x = document.querySelector(".blog_x");
var blog_page = document.querySelector(".card_blog");

blog_x.addEventListener("click", function()
{
    blog_page.style.display = "none";
})
