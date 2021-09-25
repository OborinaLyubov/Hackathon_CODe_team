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
let selected_role;

let users = [
    {
        id: 0,
        data:{
            strahovka_num:111111,
            strahovka_date: '02.01.17',
            credit_num: 123123,
            credit_date: '01.01.17'

        },
        user: "Petrov Vasiliy Sergeevich",
        role: 'client',
        transaction_details:{
            date:['01.01.17',
                '02.01.17',
                '22.01.17',
                '23.02.18',
                '24.03.18',
                '25.04.19'],
            action:['Заключение кредитного договора',
                'Заключение страхового договора',
                'Смена банка',
                'Смена страховой компании',
                'Смена клиента',
                'Полное погашение кредита']
        }

    },
    {
        id: 1,
        data:{
            strahovka_num:222222,
            strahovka_date: '21.08.19',
            credit_num: 234234,
            credit_date: '21.08.19'
        },
        user: "Strahovaya companya №1",
        role: 'strahovka',
        transaction_details:{
            date:['21.08.19',
                '21.08.19',
                '22.08.20',
                '23.08.20',
                '24.09.20',
                '23.09.21'],
            action:['Заключение кредитного договора',
                'Заключение страхового договора',
                'Смена банка',
                'Смена страховой компании',
                'Смена клиента',
                'Полное погашение кредита']
        }
    },
    {
        id: 2,
        data:{
            strahovka_num:333333,
            strahovka_date: '21.07.19',
            credit_num: 345345,
            credit_date: '21.06.19'
        },
        user: "Bank №1",
        role: 'bank',
        transaction_details:{
            date:['21.06.19',
                '21.07.19',
                '22.06.20',
                '23.06.20',
                '24.06.20',
                '23.09.21',
            ],
            action:['Заключение кредитного договора',
                'Заключение страхового договора',
                'Смена банка',
                'Смена страховой компании',
                'Смена клиента',
                'Полное погашение кредита']
        }
    }
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

/*btn_change_data_client.addEventListener('click',function (){
    toggle();
});

btn_change_big_data.addEventListener('click',function (){
    toggle();
});

btn_close_popup.addEventListener('click',function (){
    toggle();
});*/

btn_show_trans_data.addEventListener('click',function (){
    show_user_data(selected_role);
});

function show_user_data(role){
    let index = users.indexOf(users.find(fnd => fnd.role == role));
    let index_trans = users[index].transaction_details.date.indexOf(trans_list.value);
    let transaction_date = users[index].transaction_details.date[index_trans];
    let transaction_action = users[index].transaction_details.action[index_trans];
    if(transaction_date != undefined && transaction_action!=undefined){
        about_big_data.innerText = 'Данные о транзакции:\n';
        about_big_data.innerText += `Дата транзакции: ${transaction_date}\nДействие: ${transaction_action}`;
        about_client.innerText = 'Данные о пользователе:';
        about_client.innerText += `\nНомер страхового договора: ${users[index].data.strahovka_num}
        Дата страхового договора: ${users[index].data.strahovka_date}
        Номер кредитного договора: ${users[index].data.credit_num}
        Дата кредитного договора: ${users[index].data.credit_date}`;
    }else {
        alert('Выберите транзакцию из списка!');
    }

}


function find_by_role(finding_role){
    let index = users.indexOf(users.find(fnd => fnd.role == finding_role));
    profile_clear();
    role_name.innerText += ` ${users[index].role}`;
    profile_name.innerText += ` ${users[index].user}`;
    trans_list.innerHTML='';
    for(let i = users[index].transaction_details.date.length-1; i >= 0 ; i--){
        trans_list.innerHTML += `<option>${users[index].transaction_details.date[i]}</option>`
    }
    selected_role = finding_role;
}

function profile_clear(){
    role_name.innerText = `Роль:`;
    profile_name.innerText = `Название(ФИО):`;
}

/*
function toggle(){
    let blur = document.getElementById('blur');
    blur.classList.toggle('active');
    let popup = document.getElementById('popup');
    popup.classList.toggle('active');
}*/
