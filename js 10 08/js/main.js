"use strict" //kazkoks klaidu gaudymo priemone error handling

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
/*
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
*/

/*
knyguPavadinimai(knygos);//JS funkcijos rasomos is mazosios raides, nes is didziosiso raides kuriamas Konstruktorius


function knyguPavadinimai(pavadinimai)
{
	let pavadinimaiIsvest = [];
	for(let i in pavadinimai)
	    for(let knyga of pavadinimai[i])
	        pavadinimaiIsvest.push(knyga.pavadinimas)
	for(let i = 0; i < pavadinimaiIsvest.length; i++)
	    console.log(pavadinimaiIsvest[i]);
}
*/
VipReader.prototype.output = function()
{
	console.log(this.name);
	console.log(this.surname);
	console.log(this.books);
	console.log(this.rank);
}
Reader.prototype.output = function()
{
	console.log(this.name);
	console.log(this.surname);
	console.log(this.books);
}

function Reader(name, surname, books)
{
	this.name=name;
	this.surname=surname;
	this.books=books;
	/*iskelem is konstruktoriaus isvedimo f-ija ir sukurem sito objekto prototipo f-ija isoreje isvedimui 84eilute (oldschoolinis naudojimas)
	this.output = function()
	{
		console.log(this.name);
		console.log(this.surname);
		console.log(this.books);
	}
	*/

}

function VipReader(name, surname, books, rank)
{
	Reader.call(this, name, surname, books);/*paveldejimas oldschooliniu budu*/
	this.rank=rank;
}

let skaitytojas1 = new VipReader("jonas", "ponas", ["zuikis puikis", "grybu karas", "raudon kepuraite"], "notVIP");
let skaitytojas2 = new Reader("onute", "mazute", ["haris poteris", "ziedu valdovas", "vakaru fronte nieko naujo"]);
let skaitytojas3 = new VipReader("petriukas", "siaubukas", ["JS bukiems", "C# enciklopedija", "HTML5 pagrindai"], "VIP");

skaitytojas1.output();
skaitytojas2.output();
skaitytojas3.output();

/*ES6 darbas su console.log isvedimu be + tarp stringu ir kintamuju*/
let vardas = "Jonas";
let email = "mano@gmail.com";
let preke = "pienas";
let kiekis = 12;
let kaina = 1200;

console.log(`Mano vardas yra ${vardas} ir turiu el paštą: ${email}. Vakar pirkau ${preke} ir sumokėjau viso: ${kiekis*kaina}`);

/*ES6 array arba objec'o destruction*/
let [firstName, middleName, lastName] = ["Dylan","God programer","Israel"];

console.log(firstName);


let duomenys = ["jonas", "ona", "andrius", "jonas", "jonas"];/**neveikia :(*/

function jonoRadimas(array, missing)
{
		
	for (const element of array) {
		if(array.includes(element)){
		console.log(array);
		}else{
			console.log("Nieko neradom");
		}
	}


}


jonoRadimas(duomenys, "jonas");


class ReaderClass{
	constructor(name, surname, books){
		this.name = name;
		this.surname = surname;
		this.books = books;
	}

	setRank(rank){//seteris metodas
		this.rank=rank;
	}

	greeting(){//geteris metodas
		console.log(`Labas, as esu ${this.name} ${this.surname} mano reitingas yra ${this.rank}`);
	}
	farwell(){
		console.log(`${this.name} ${this.surname} paliko biblioteka`);
	}


}

let skaitytojas4 = new ReaderClass("petriukas", "siaubukas", ["JS bukiems", "C# enciklopedija", "HTML5 pagrindai"]);

skaitytojas4.rank("VIP");

skaitytojas4.greeting();




//labas diena