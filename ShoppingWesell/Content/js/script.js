(function(jQuery){
    jQuery(document).ready(function () {


        $("#form").bind('invalid-form.validate',

        function (form, validator) {
            var errors = "Cadastro de Loja:\r";

            for (var i = 0; i < validator.errorList.length; i++) {
                errors = errors + "\r\t-" + validator.errorList[i].message;
            }

            alert(errors);


        }
        );

        //$('#PorcentagemDesconto').setMask();

		/* ===================
		   Evento hover para menu principal
		   ================================== */
		localHover = 0;
		jQuery('#menu-principal ul > li.sfHover').hover(function(){
			localHover = jQuery('#menu-principal ul > li.sfHover').index(this);    
			jQuery('ul.sub-menu:eq('+localHover+')').css('display','block');
		},
		function(){
			jQuery('ul.sub-menu:eq('+localHover+')').css('display','none');
		});
		
		/* efeito âncora para voltar ao topo da pagina */		
			jQuery(window).scroll(function () {
				if (jQuery(this).scrollTop() > 500) {
					jQuery('#voltar-top').fadeIn();
				} else {
					jQuery('#voltar-top').fadeOut();
				}
			});

			// scroll body to 0px on click
			jQuery('#voltar-top a').click(function () {
				jQuery('body,html').animate({
					scrollTop: 0
				}, 1000);
				return false;
			});
	
		
		/* Evento hover para carrinho */
		var passou = true;
		jQuery('.SemBorda-Menu').hover(function(){			
			jQuery('#detalhe_cart .block_content').stop().slideDown(1000);
			passou = true;
		},
		function(){
			jQuery('#detalhe_cart .block_content').mouseenter(function(){
				passou = false;
				jQuery('#detalhe_cart .block_content').css('display','block');
			}).mouseleave(function(){
				setTimeout(function(){
					jQuery('#detalhe_cart .block_content').stop().slideUp(1000);
				},800);			  
			});
			
			setTimeout(function(){
				if(passou)
					jQuery('#detalhe_cart .block_content').stop().slideUp(1000);
			},800);
		});
		
		/******* Evento hover para mudar imagem em destaque *********/
		var proximaImagem = 0;
		jQuery('#thumbs-Lista li').hover(function(){
			proximaImagem = jQuery('#thumbs-Lista li').index(this);			
			jQuery('#image-main img').attr('src', '/Content/images/img-Grande_0' + proximaImagem + '.jpg')
		});
		
		/******* Evento click para abas Detalhe do produto *********/
		/* Por default box mais informação */
		jQuery('.detalhes-description:eq(' + 0 + ')').css('display','block');
		var r = 0;
		jQuery('#description .abas-description li a').click(function(i){
			jQuery('.detalhes-description').css('display','none');
			jQuery('#description .abas-description li a').removeClass('abas-descriptionSelected');			
			r = jQuery('#description .abas-description li a').index(this);
			jQuery('.detalhes-description:eq(' + r + ')').css('display','block');
			jQuery('#description .abas-description li a:eq(' + r + ')').addClass('abas-descriptionSelected');	
		});
		
		/********* Evento hover para btn fechar *****************/
		jQuery('.Box-Avaliar div.Fechar a').hover(function(){
			jQuery('.Box-Avaliar div.Fechar span').css('background-position','0 -16px');
		}, function(){
			jQuery('.Box-Avaliar div.Fechar span').css('background-position','0 0');
		});
		
		/********* Evento clique para btn fechar *****************/
		jQuery('.Box-Avaliar div.Fechar a, #Box-Overlay').live('click',function(){
			jQuery('#Box-Overlay').fadeOut(1000);
			jQuery('.Box-Avaliar div.Fechar').parent().fadeOut(1010);			
		});
		
		/********* Evento clique para mostrar formulario para avaliação *****************/
		jQuery('.bt_avalie, #Box-AvalieIndique a:eq(0)').live('click',function(){ 
			jQuery('#Box-Overlay').fadeIn(1000); 
			jQuery('.Box-Avaliar:eq(0) div.Fechar').parent().fadeIn(1010);
		});
		
				
		/********* Evento clique para mostrar formulario para indicar para um amigo *****************/
		jQuery('#Box-AvalieIndique a:eq(1)').live('click',function(){ 
			jQuery('#Box-Overlay').fadeIn(1000); 
			jQuery('.Box-Avaliar:eq(1) div.Fechar').parent().fadeIn(1010);
		});
		
		/* Evento scroll para direcionar para  Avaliação do cliente */
		jQuery('.icoAvaliacaoCliente').live('click',function(){ 
			jQuery('body,html').animate({
					scrollTop: 600
			}, 1000);
			jQuery('#description .abas-description li a:eq(' + 1 + ')').click()
			return false;
		});
		
		
		//preencher option data de nascimento
		for(var i = 1; i < 32; i++){
			jQuery('.Dia').append('<option value="'+i+'">'+i+'</option>');
		}
		
		for(var j = 2013; j >= 1940; j--){
			jQuery('.Ano').append('<option value="'+j+'">'+j+'</option>');
		}
		
		var meses = new Array('Janeiro','Fevereiro','Marco','Abril','Maio','Junho','Julho','Agosto','Setembro','Outubro','Novembro','Dezembro');
		for(var m = 0; m < 12; m++){
			jQuery('.Mes').append('<option value="'+(m+1)+'">'+meses[m]+'</option>');
		}
		
		
		// evento clique para selecionar tipo de pagamento
		var ind = 0;
		jQuery('h2.TipoPagamento').live('click',function(event){
			jQuery('.box-forma-pagamento').css('display','none');
			ind = jQuery('h2.TipoPagamento').index(this);
			jQuery('.box-forma-pagamento:eq('+ ind +')').css('display','block');
		});
		
		/************ evento clique para mostrar e esconder endereço de entrega diferente ******************************/
		var EndDiferente = true;
		jQuery('input#EndIgualConbranca').live('click',function(){
			if(EndDiferente){
			   jQuery('.Form_EndEntrega').css('display','block');
			   jQuery(' p.Btn_Conti:first').css('display','none');  
			   EndDiferente = false;
			}else{
				jQuery('.Form_EndEntrega').css('display','none');
				jQuery(' p.Btn_Conti:first').css('display','block');
				EndDiferente = true;
			}
		});
		
		/************ newslettes ******************************/
		jQuery('a.CadastarSE').live('click',function(){
			jQuery('.last_Box').hide();
			jQuery('.Box:eq(0)').fadeIn(1010);
		});
		
		jQuery('#box_newslettes div.Fechar a').live('click',function(){
			jQuery('.last_Box').fadeIn(1010);
			jQuery('.Box:eq(0)').hide();
			document.getElementById("Email_NewsLetter").value = "Digite seu e-mail"
			document.getElementById("Nome_NewsLetter").value = "Digite seu nome";
		});
		
		//Evento Formulario para input nome
		jQuery('input#Nome_NewsLetter').live('blur',function(){
		  if(jQuery(this).val() == ""){
			jQuery(this).val('Digite seu nome');
		  }
		});

		//Evento Clique para input nome
		jQuery('input#Nome_NewsLetter').live('click',function(){
		  if(jQuery(this).val() == 'Digite seu nome'){
			jQuery(this).val('');
		  }
		});
		//Evento Formulario para input e-mail
		jQuery('input#Email_NewsLetter').live('blur',function(){
		  if(jQuery(this).val() == ""){
			jQuery(this).val('Digite seu e-mail');
		  }
		});

		//Evento Clique para input e-mail
		jQuery('input#Email_NewsLetter').live('click',function(){
		  if(jQuery(this).val() == 'Digite seu e-mail'){
			jQuery(this).val('');
		  }
		});
		
		jQuery('.box_Cadastrar a').live('click',function(){
			ReceberOfertas();
		});

		
	
		function ReceberOfertas(){
			var email = jQuery.trim(document.getElementById("Email_NewsLetter").value);
			var nome = jQuery.trim(document.getElementById("Nome_NewsLetter").value);		
		
			if (nome == "")
			{
				alert("Por favor, preencha seu nome.");
				
			}
			else if (nome == "Digite seu nome")
			{
				alert("Por favor, digite seu nome.");
				
			}
			else if (email == "")
			{
				alert("Por favor, preencha seu e-mail.");
				
			}
			else
			{
				if (!ValidaEmail(email))
				{
					alert("E-mail inválido!");				
				}
				else
				{
					//Ativar função para enviar newsletter	
					alert('Enviado com sucesso!!');
				}
			}
		}
		
		/*======
			BannerDemostrativo - Carrosel
		=====*/
		/****** mostra primeiro produto *********/
		jQuery('div.IMG_Dest li:first').show();
		jQuery('div.Prod_Desmostrativo div:first').show();

		var intervalo = "";
		var clicou = 0;
		var inicio = "";
		
		function carroselBox_Demostrativo(i){
			/****** reset ********/
			jQuery('.CriarBorda li').removeClass('CriarBorda_Selected');
			jQuery('div.IMG_Dest li').hide(); 
			jQuery('div.Prod_Desmostrativo div').hide(); 
			
		   /****** show no proximo elemento ********/
		   jQuery('div.IMG_Dest li:eq('+i+')').fadeIn(1200);// show na imagem
		   jQuery('div.Prod_Desmostrativo div:eq('+i+')').effect('shake', { times:1 }, 300); // efeito shake na descrição do produto
		   jQuery('.CriarBorda li:eq('+i+')').addClass('CriarBorda_Selected');// add borda preta no lado left da img pequena do lado direito
			
			i+=1;
			if(i >= 4){ i = 0; }
			clearInterval(intervalo);
			intervalo = window.setInterval(function(){
				carroselBox_Demostrativo(i);
			},9000);	
		}

		//ativa o carrosel
		//intervalo = window.setInterval('carroselBox_Demostrativo(1)', 9000);
		inicio = setTimeout(function() {
			carroselBox_Demostrativo(1)
		}, 9000);
		
		jQuery('div.List_Demostrativo ul li').live('click',function(){
			clearInterval(intervalo);//cancela possivel função ativa
			clearTimeout(inicio);//cancela a função inicial
			clicou = jQuery('div.List_Demostrativo ul li').index(this);	//verifica onde foi clicado
			carroselBox_Demostrativo(clicou);//carrega função para efetuar a troca	
		});

		/*
			selector.effect( "shake", {arguments}, speed );
			- times: Times to shake. Default is 3.
			- distance:Distance to shake. Default is 20.
			- direction:The direction of the effect. Can be "up", "down", "left", "right". Default is "left"
		*/



	
	});
})(jQuery);