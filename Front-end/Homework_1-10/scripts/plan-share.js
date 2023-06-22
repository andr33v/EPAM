//Plan button
const plan = document.getElementById("tripPlan");
const planButton = document.getElementById("button__plan");
const closePlan = document.querySelector(".plan-close");
const submitButton = document.getElementById("submit-button");
const page = document.querySelector(".main");

planButton.addEventListener("click", function(){
    if(localStorage.getItem("currentUser") !== null){
        plan.style.display = "block";
        page.classList.add("blur-background");
    }
    else{
        alert("Log in to your account to get personal support!");
    }
});

closePlan.addEventListener("click", function(){
    plan.style.display = "none";
    page.classList.remove("blur-background");
});

window.addEventListener("click", (event) => {
    if (event.target === plan){
        plan.style.display = "none";
        page.classList.remove("blur-background");
    }
});

submitButton.addEventListener("click", function(){
    const mail = document.getElementById("email").value;
    const desc = document.getElementById("description").value;

    if(mail.indexOf("@") === -1)
    {
        alert("Please enter your email!");
        return;
    }

    let domain = mail.split("@");
    if (domain.length !== 2 || domain[0] === "" || domain[1] === "" || domain[1].split(".").length !== 2) {
        alert("Please enter a valid email!");
        return;
    }

    if(desc === "")
    {
        alert("Please enter a description!");
        return;
    }

    const request = {
        mail: mail,
        desc: desc,
    };

    const allResponses = Object.keys(localStorage).filter(key => key.endsWith("Response"));
    const isExistingEmail = allResponses.some(key => {
        const response = JSON.parse(localStorage.getItem(key));
        return response.mail === mail;
    });

    if(localStorage.getItem(user.login + "Response") !== null || isExistingEmail){
        alert("We already received an request from you!");
    }
    else{
        addUserRequest(user, request);
    }  

    alert("Thanks for submitting!");
    document.getElementById("email").value = "";
    document.getElementById("description").value = "";
    plan.style.display = "none";
    page.classList.remove("blur-background");
});

const user = JSON.parse(localStorage.getItem("currentUser"));
function addUserRequest(user, request){
    localStorage.setItem(user.login + "Response", JSON.stringify(request));
}

//Share button
const share = document.getElementById("button__share");
let userShares;
if(localStorage.getItem("currentUser") !== null){
    userShares = JSON.parse(localStorage.getItem(user.login + "Shares"));
}
    if (!userShares) {
    userShares = {
        count: 0
    };
}

share.addEventListener("click", function(){
    if(localStorage.getItem("currentUser") === null){
        alert("Log in to an account to share your experience!");
    }
    else{
        window.open("https://www.instagram.com/explore/tags/travels/");
        userShares.count = getCurrentUserShares(userShares);
        countUserShares(userShares);
    }
});

function countUserShares(userShares){
  localStorage.setItem(`${user.login}Shares`, JSON.stringify(userShares));
}

function getCurrentUserShares(userShares){
  userShares.count += 1;
  return userShares.count;
}