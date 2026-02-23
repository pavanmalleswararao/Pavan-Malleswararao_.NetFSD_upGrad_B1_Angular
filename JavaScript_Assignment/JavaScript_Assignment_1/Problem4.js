let signal="yellow";

switch(signal){
    case "red":
        console.log('stop');
        break;
    
    case 'yellow':
        console.log('Get Ready');
        break;
    
    case 'green':
        console.log('Go');
        break;

    default:
        console.log("Invalid signal color");
}