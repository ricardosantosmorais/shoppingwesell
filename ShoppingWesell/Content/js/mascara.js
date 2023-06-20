//Remove tudo o que não é dígito
function apenasNumeros(s){ 
	var valor = s.value; 	
	valor = valor.replace(/\D/g,""); 
	return document.getElementById(s.id).value = valor;
} 

//Mascara para CEP
function MascaraCEP(c){   
    var r = c.value;	
    r = r.replace(/^(\d{5})(\d)/,"$1-$2");    
	return document.getElementById(c.id).value = r;
}
//Mascara para CPF
function MascaraCPF(v){
	var cpf = v.value;               
    cpf=cpf.replace(/(\d{3})(\d)/,"$1.$2");
    cpf=cpf.replace(/(\d{3})(\d)/,"$1.$2");

    cpf=cpf.replace(/(\d{3})(\d{1,2})$/,"$1-$2");
    return document.getElementById(v.id).value = cpf;
}

//Mascara para telefone (11) 1111-1111
function MascaraFone01(f){
	var fone = f.value;
	fone = fone.replace(/(\d{0})(\d)/,"$1($2");
	fone = fone.replace(/(\d{2})(\d)/,"$1)$2");	
	fone = fone.replace(/(\d{4})(\d)/,"$1-$2");
	return document.getElementById(f.id).value = fone;
}

//verifica e-mail
function ValidaEmail(email){
	var retorno = true;
	var filter=/^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i ;			  
	if (!filter.test(email)) 
	{
		retorno = false;
	}
	return retorno;
}