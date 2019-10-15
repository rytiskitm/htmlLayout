let xhr = new XMLHttpRequest();/*sukuriamas objektas*/
let mokiniuDIV = document.querySelector('.mokiniai');
xhr.onreadystatechange = function (){/*Callback funkcija*/
    if(xhr.readyState ===4)
    {
        if(xhr.status ===200){/*serverio statusas 200*/
            document.querySelector('.mokniai').innerHTML = xhr.responseText;/**/
        }else{
            alert(xhr.statusText);
        }
    }


    a = JSON.parse(xhr.responseText);
    console.log(a);
    let text="";
    let yra ="";
    for (let mokinys of a){
        if(mokinys.lokacija){
            yra="klaseje yra ";
        }else{
            yra="klaseje nera ";
        }
        text+="<p>"+yra+mokinys.vardas+"</p>";
    }
    mokiniuDIV.innerHTML=text;




};
xhr.open('GET','duomenys/mokiniai.json');
xhr.send();

