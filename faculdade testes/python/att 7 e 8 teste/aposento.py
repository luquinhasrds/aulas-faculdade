import os
from time import sleep
n_da_consulta = 0
consultas = []
while True:
    #opcoes para escolha ------------------------------------------------------------
    print('----Escolha uma opção----')
    print(
        '''
        [1]-Consultar aposentadoria-

        [2]-Ver todas as consultas-

        [0]-Para sair do programa-

        '''
    )
    #LE A OPCAO QUE O USUARIO ESCOLHEU
    try:
        opcao = int(input('Digite qual a opção desejada: '))
    except ValueError:
        print('SELECIONE UMA DAS OPÇÕES ACIMA CARAIO')
        sleep(1.5)
        continue
    if opcao == 1:
        #informacoes para fazer a consulta ----------------------------------------------
        print('-'*15)
        nome = input("Nome: ")
        sexo = input("Sexo: (M/F): ")
        # IF E ELIF PARA ESCREVER O SEXO POR EXTENSO
        if sexo == 'm' or 'M':
            sexo = 'Masculino'
        elif sexo == 'f' or 'F':
            sexo = 'Feminino'
        idade = int(input("Idade: "))
        contribuicao = int(input("Tempo de contribuição (ANOS): "))
        #if e else se pode ou nao se aposentar ------------------------------------------
        if (sexo == 'Masculino' and contribuicao >= 30 and idade >= 55) or (sexo == 'Feminino' and contribuicao >=35 and idade >= 60):
            print(f"{nome} pode se aposentar.")
            aposentado = True
            print('='*60)
            sleep(1.5)
        else:
            print(f"{nome} não pode se aposentar.")
            aposentado = False
            print('='*60)
            sleep(1.5)
        #dicionario das informacoes ----------------------------------------------------
        n_da_consulta += 1 
        consulta = {
            "numero":n_da_consulta,
            'nome':nome,
            'sexo':sexo,
            'idade':idade,
            'contribuicao':contribuicao,
            'aposento':aposentado
        }
        consultas.append(consulta)
    #continuacao da opcao 1 do menu-----------------------------------------------------
    elif opcao == 2:
        if n_da_consulta == 0:
            print('-----SEM CONSULTAS NO MOMENTO-----')
            sleep(3)
        else:
            print('='*60)
        print('consultas realizadas:')
        #PRINTA AS CONSULTAS ---------------------------------
        for consulta in consultas:
            print(f'Número da consulta: {consulta["numero"]}')
            print(f'Nome: {consulta["nome"]}')
            print(f'Sexo: {consulta["sexo"]}')
            print(f'Idade: {consulta["idade"]}')
            print(f'Tempo de contribuição: {consulta["contribuicao"]} anos')
            if consulta['aposento']:
                print('PODE SE APOSENTAR')

            else:
                print('NÃO PODE SE APOSENTAR.')
                
            print('='*60)
    #SAIR DO PROGRAMA -----------------------------------------------------------------
    elif opcao == 0:
        print('Saindo do programa.....')
        sleep(1.5)
        break
    elif opcao != 0 or opcao !=1 or opcao != 3:
        print("OPÇÃO INVALIDA. Tente novamente.")
        print('='*60)
