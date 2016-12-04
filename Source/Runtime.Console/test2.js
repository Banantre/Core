class something
{
    addNumbers(callback, first, second) {
        var result = first+second;
        console.log("Added numbers : "+result);
        callback(null, result);
   }
}

module.exports = new something();

