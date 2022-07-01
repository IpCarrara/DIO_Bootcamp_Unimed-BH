// Desafio_Introdução Prática ao TypeScript - Bootcamp Unimed

//Crie um projeto em TypeScript com uma abordagem totalmente prática.

/* Descrição: Alunos de um colégio que poderão participar de um evento
esportivo dependendo do seu estado de vacinação */

console.log("ALUNOS QUE PODEM IR AO EVENTO:")
console.log(" ")

interface Alnos {
    nome: string;
    sala: number;
    vacinado: boolean;
};

const aluno1: Alnos =  {
    nome: "Carlos Silva",
    sala: 201,
    vacinado: true,
};

const aluno2: Alnos =  {
    nome: "Maria Santos",
    sala: 102,
    vacinado: true,
}

const aluno3: Alnos =  {
    nome: "Vitor Castro",
    sala: 303,
    vacinado: false,
}

const aluno4: Alnos =  {
    nome: "Fernanda Pereira",
    sala: 303,
    vacinado: false,
}

let aluno = [aluno1, aluno2, aluno3, aluno4];

for (let i = 0; i < aluno.length; i++) {
    if (aluno[i].vacinado === true) {
        console.log("- " + aluno[i].nome);
    }
}
