const kiekioDiv = document.querySelector('.kiekioIvedimas');
const vardoDiv = document.querySelector('.vardoIvedimas');
const kiekis = document.querySelector('.kiekis');
const kiekioIvedimoButton = document.querySelector('.kiekioIvedimoButton');
const vardas = document.querySelector('.vardas');
const vardoIvedimoButton = document.querySelector('.vardoIvedimoButton');


kiekioIvedimoButton.addEventListener('click', kiekioIvedimo);

function kiekioIvedimo()
{
    let dalyviai = kiekis.value;
    if (isNaN(dalyviai)||dalyviai<0){
        location.reload();
    }else{
        vardoIvedimoButton.addEventListener('click', vardoIvedimo(vardas.value));
    }
}

function vardoIvedimo(a){
console.log("atejo i funkcija");
    let sveciai = [];
    console.log(a);

    for(i=0;i<a;i++){
        sveciai[i]=vardas.value;
    }


console.log(sveciai);
}

function run(){//sukuria li elementu vudeje savo tevinio elemento(appendChild) viduje siuo atveju li elemento tevinis elementas yra ul
    let li = document.createElement('li');
    li.textContent = input.value;
    list.appendChild(li);
}

function remove(){
    list.removeChild(lastTask);//paskutini elementa pasalina is listo
}