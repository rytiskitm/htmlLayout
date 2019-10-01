"use strict" //kazkoks klaidu gaudymo priemone error handling
/*
var prekesPavadinimas = "Obuolys";
var prekesAprasymas = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam gravida sollicitudin egestas. LABAS LABASLABASLABASLABASLABASLABASLABASLABASLABAS";
var kiekis = 5;
var nuolaida = 30;
var kaina = 22;
var apskaiciuotaNuolaida;
apskaiciuotaNuolaida = kaina/100*nuolaida;


console.log("Prekė: "+prekesPavadinimas);

if (prekesPavadinimas.length<100){
	var trumpasAprasymas = prekesAprasymas.substr(0, 100);
	console.log("Prekės aprašymas: "+trumpasAprasymas);
}else{
	console.log("Prekės aprašymas: "+prekesAprasymas);	
}
console.log("Kaina vnt.: "+kaina);
console.log("Kiekis vnt.: "+kiekis);
console.log("Nuolaida eur: "+apskaiciuotaNuolaida);
console.log("Suma: "+kiekis * (kaina-apskaiciuotaNuolaida));

*/

/* //masyvas
var kategorija = "vadovas";
var prekes = ['pienas',10,true,function(){console.log("Sveiki")}];

console.log(prekes[0]);

for(let i=0; i<prekes.length; i++)
{
	console.log(prekes[i]);
}
*/
/*//dvinaris masyvas
let katalogas[
	['pienas','kava','grietine','duona'],
	['ratas','padanga','tepalas'],
	['kompiuteris','telefonas','monitorius','pele','klava'],
]
*/
/*
let katalogas = ['maistas','auto','iranga'];
katalogas[0]=['pienas','kava','grietine','duona'];
katalogas[1]=['ratas','padanga','tepalas'];
katalogas[2]=['kompiuteris','telefonas','monitorius','pele','klava'];

for(let i=0; i<katalogas.length; i++)
{
	console.log("\n");
	console.log(katalogas[10]);
	console.log("\n");
	for(let j=0; j<katalogas[i].length; j++)
	{
		console.log(katalogas[i][j]);
	}

}
*/

/*
//objekto "vartotojas" deklaravimas
let vartotojas={
				prekesPavadinimas:"Obuolys",
				prekesAprasymas:"Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
				kiekis:5,
				nuolaida:30,
				kaina:120
};
//ejimas per objekto elementus naudojant for in konstrukcija
for(let objektoElementas in vartotojas){
	console.log(vartotojas[objektoElementas]);
}


let katalogas = {
	maistas:['pienas','alus','duona'],
	iranga:['kompiuteris','pele','klava','monitorius','telefonas'],
	auto:['ratas','padanga','tepalas']
}
for(let objektoElementas in katalogas){
	console.log(objektoElementas.toUpperCase()+": ");

	for(let i = 0; i<katalogas[objektoElementas].length;i++){
		console.log(katalogas[objektoElementas][i]);

	}
	console.log("\n");
}

let kaina = 700;

//deklaruojant kintamaji tikrinimo salyga iskart
let pastaba = (kaina>800) ? 'brangu':'pigu';
console.log(pastaba);
*/

let knygos={
	siaubo:
	[
		{
			isbn:"dksk",
			metai:2009,
			pavadinimas:"Jonukas ir Gritute",
			psl:321
		},
		{
			isbn:"ujjjk",
			metai:2019,
			pavadinimas:"Ponas siaubas",
			psl:254
		},
		{
			isbn:"5554",
			metai:1852,
			pavadinimas:"Kempinukas",
			psl:523
		},
		{
			isbn:"apak",
			metai:2000,
			pavadinimas:"Pepe ilgakoine",
			psl:874
		}

	],
	vaiku:
	[
		{
			isbn:"6252",
			metai:2019,
			pavadinimas:"Grybu karas",
			psl:870
		},
		{
			isbn:"hkjuhjgh",
			metai:2019,
			pavadinimas:"Zuikis puikis",
			psl:654
		}
	],
	grozine:
	[
		{
			isbn:"55",
			metai:1999,
			pavadinimas:"Kapitono granto vaikai",
			psl:123
		},
		{
			isbn:"hkju996hjgh",
			metai:2019,
			pavadinimas:"Varkdieniai",
			psl:357
		},
		{
			isbn:"oooo",
			metai:2005,
			pavadinimas:"Davincio kodas",
			psl:545
		}

	]
}
console.log("--------------------");
for(let objektoElementas in knygos){
	//isvedam objekto elementu pavadinimus
	console.log(objektoElementas.toUpperCase()+" literatura: "+"("+knygos[objektoElementas].length+" knygų)");

	console.log("--------------------");
	for(let i = 0; i<knygos[objektoElementas].length;i++){
	//einam per masyvo elementus
		for(let knygosElementas in knygos[objektoElementas][i]){

			if(knygosElementas=="metai" && knygos[objektoElementas][i][knygosElementas] == 2019){
				console.log("Leidimo metai: "+knygos[objektoElementas][i][knygosElementas]+" (nauja knyga)");
			}else{
				if(knygosElementas=="pavadinimas"){
					console.log("Pavadinimas: "+knygos[objektoElementas][i][knygosElementas]);
				}
				else{
					if(knygosElementas=="psl"){
						console.log("Puslapių skaičius: "+knygos[objektoElementas][i][knygosElementas]);
					}
					else{
						if(knygosElementas=="isbn"){
							console.log("ISBN: "+knygos[objektoElementas][i][knygosElementas]);
						}
						else{
							console.log("Leidimo metai: "+knygos[objektoElementas][i][knygosElementas]);
						}

					}

				}
			}
			
		}
		console.log("\n");
	}
	console.log("--------------------");
}

/*

for(let objektoElementas in knygos){
	console.log(objektoElementas.toUpperCase()+": ");

	for(let i = 0; i<knygos[objektoElementas].length;i++){
		console.log(knygos[objektoElementas][i]);

		for(let labas in knygos[i]){
			console.log(labas);

		}

	}
	console.log("\n");
}

*/