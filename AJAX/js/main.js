let manoAjax = new XMLHttpRequest();/*sukuriamas objektas*/
manoAjax.onreadystatechange = function (){/*Callback funkcija*/
    if(manoAjax.readyState ===4)
    {
        if(manoAjax.status ===200){/*serverio statusas 200*/
            document.querySelector('aside').innerHTML = manoAjax.responseText;/**/
        }else{
            alert(manoAjax.statusText);
        }
    }
};

manoAjax.open('GET','meniu.html');
document.querySelector('button.showMenu').onclick = function(){
    manoAjax.send();
    document.querySelector('button.showMenu').style.display="none";
};