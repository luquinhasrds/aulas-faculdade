while True:
    senha = (input('Digite sua senha de acesso:'))
    tem_maiuscula = False
    tem_numero = False
    for caracteres in senha:
        if caracteres.isnumeric():
            tem_numero = True
        elif caracteres.isupper():
            tem_maiuscula = True

    if (len(senha)>=8) and tem_numero and tem_maiuscula:
        print('------SENHA VALIDA------')
    else:
        print('------SENHA INVALIDA------')
    print('='*30)