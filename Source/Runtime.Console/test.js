module.exports = {
    addNumbers: function(callback, first, second) {
        var result = first+second;
        console.log("Added numbers : "+result);
        callback(null, result);
    }
};

