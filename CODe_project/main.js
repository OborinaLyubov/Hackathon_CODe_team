/*Объявляем переменные согласно id в html*/
let btn_change_data_client = document.getElementById('change-data-client');
let btn_change_big_data = document.getElementById('change-big-data');
let btn_close_popup = document.getElementById('close-popup');
let btn_delete_big_data = document.getElementById('delete-big-data');
let btn_show_trans_data = document.getElementById('show-trans-data');
let client_role = document.getElementById('client-role');
let strahovka_role = document.getElementById('strahovka-role');
let bank_role = document.getElementById('bank-role');
let role_name = document.getElementById('role-name');
let profile_name = document.getElementById('profile-name');
let about_client = document.getElementById('about-client');
let about_big_data = document.getElementById('about-big-data');
let trans_list = document.getElementById('trans-list');


let users = [
    {
        id: 0,
        data:{
            strahovka_num:111111,
            strahovka_date: '18.04.21',
            credit_num: 123123,
            credit_date: '17.04.21'

        },
        created:'17.04.21',
        user: "Petrov Vasiliy Sergeevich",
        role: 'client',
        transaction_list:[
            '17.04.21',
            '17.05.21',
            '17.06.21',
            '17.07.21'
        ],
        transaction_details:{
            date:[],
            action:[],
            date_end:[]
        }

    },
    {
        id: 1,
        data:{
            strahovka_num:222222,
            strahovka_date: '03.03.21',
            credit_num: 234234,
            credit_date: '02.03.21'
        },
        created:'02.03.21',
        user: "Strahovaya companya №1",
        role: 'strahovka',
        transaction_list:[
            '02.03.21',
            '02.04.21',
            '02.05.21',
            '02.06.21'
        ],
        transaction_details:{
            date:[],
            action:[],
            date_end:[]
        }
    },
    {
        id: 2,
        data:{
            strahovka_num:333333,
            strahovka_date: '26.06.21',
            credit_num: 345345,
            credit_date: '25.06.21'
        },
        created:'25.06.21',
        user: "Bank №1",
        role: 'bank',
        transaction_list:[
            '25.06.21',
            '25.07.21',
            '25.08.21',
            '25.09.21'
        ],
        transaction_details:{
            date:[],
            action:[],
            date_end:[]
        }
    },
];

client_role.addEventListener('click',function (){
   find_by_role('client');
});

strahovka_role.addEventListener('click',function (){
    find_by_role('strahovka');
});

bank_role.addEventListener('click',function (){
    find_by_role('bank');
});

btn_change_data_client.addEventListener('click',function (){
    toggle();
});

btn_change_big_data.addEventListener('click',function (){
    toggle();
});

btn_close_popup.addEventListener('click',function (){
    toggle();
});

btn_show_trans_data.addEventListener('click',function (){
    show_user_data('client');
});

function show_user_data(role){
    let index = users.indexOf(users.find(fnd => fnd.role == role));
    about_client.innerText = 'Данные:';
    about_client.innerText += `\nНомер страхового договора: ${users[index].data.strahovka_num}
    Дата страхового договора: ${users[index].data.strahovka_date}
    Номер кредитного договора: ${users[index].data.credit_num}
    Дата кредитного договора: ${users[index].data.credit_date}`;
}


function find_by_role(finding_role){
    let index = users.indexOf(users.find(fnd => fnd.role == finding_role));
    profile_clear();
    role_name.innerText += ` ${users[index].role}`;
    profile_name.innerText += ` ${users[index].user}`;
    trans_list.innerHTML='';
    for(let i = 0; i < users[index].transaction_list.length; i++){
        trans_list.innerHTML += `<option>${users[index].transaction_list[i]}</option>`
    }
}

function profile_clear(){
    role_name.innerText = `Роль:`;
    profile_name.innerText = `Название(ФИО):`;
}

function toggle(){
    let blur = document.getElementById('blur');
    blur.classList.toggle('active');
    let popup = document.getElementById('popup');
    popup.classList.toggle('active');
}