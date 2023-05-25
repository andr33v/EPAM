let button = document.getElementById("header__nav-item-second-button");
button.addEventListener("click", function() {
    let login = prompt("Enter your login");
    if(login != "Admin" || login === null)
    {
        alert("Access denied!");
    }
    else
    {
        let password = prompt("Enter the password");
        if(password == "12345")
        {
            alert("Welcome!");
        }
        else
        {
            alert("Wrong password!");
        }
    }
});