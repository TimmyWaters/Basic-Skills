function start() {
	var graybg = document.getElementById("graybg");
	graybg.addEventListener("click", function(){bgSet("gray");}, false);
	
	var whitebg = document.getElementById("whitebg");
	whitebg.addEventListener("click", function(){bgSet("white");}, false);
	
	var sanstext = document.getElementById("sanstext");
	sanstext.addEventListener("click", function(){textSet(1);}, false);
	
	var seriftext = document.getElementById("seriftext");
	seriftext.addEventListener("click", function(){textSet(2);}, false);
}

function bgSet(bgNew) {
	document.body.style.backgroundColor = bgNew;
}

function textSet(textNew) {
	if (textNew == 1) {
		document.getElementById("text").style.fontFamily = 'arial';
	}
	else {
		document.getElementById("text").style.fontFamily = 'times';
	}
}

window.addEventListener("load", start, false);