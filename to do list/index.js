const inputBox=document.getElementById("input-box");
const button=document.getElementById("list-container");
function AddTask(){
    if(inputBox.value===''){
        alert("You must write something");

    }
    else{
        let li = document.createElement("li")
        li.innerHTML= inputBox.value;
        button.appendChild(li);
        let span = document.createElement("span");
        span.innerHTML ="\u00d7"
        li.appendChild(span);
    }
    inputBox.value ="";
    saveData();
}
button.addEventListener("click",function(e){
    if(e.target.tagName === "LI"){
        e.target.classList.toggle("checked");
    }
    else if(e.target.tagName === "SPAN"){
        e.target.parentElement.remove();
        saveData();
    }
},false);
function saveData(){
    localStorage.setItem("data",button.innerHTML);
}
 function showTask(){
    button.innerHTML = localStorage.getItem("data")
 }
