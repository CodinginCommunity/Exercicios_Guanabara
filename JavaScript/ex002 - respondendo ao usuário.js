// Crie um script que leia o dia, o mês e o ano de nascimento de uma pessoa e mostre uma mensagem com a data formatada 

const input = require('readline-sync').question
const print = console.log

let dia = input('Qual o dia do seu nascimento? ')
let mes = input('E o mês? [1-12] ')
let ano = input('Por fim o ano: ')

print(`Você nasceu em ${dia}/${mes}/${ano}`)
