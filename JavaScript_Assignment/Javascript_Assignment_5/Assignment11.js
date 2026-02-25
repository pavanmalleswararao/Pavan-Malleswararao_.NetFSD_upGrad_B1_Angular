class User{
    constructor(password){
        this._password=password;
    }
    set password(newpassword){
        if(newpassword.length<6){
            console.log('Password contains minimum 6 chacters');
        }else{
            this._password=newpassword;
            console.log('Password updated Successfully');
        }
    }
    get password(){
        return this._password;
    }
}

let user=new User("secret1");
console.log(user.password);
user.password='123';
user.password='newpass123';
console.log(user.password);