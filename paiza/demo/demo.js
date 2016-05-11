process.stdin.resume();
process.stdin.setEncoding('utf8');

var lingeringLine = "";

function processLine(data)
{
    console.log(data);
};

process.stdin.on('data', function(chunk) {
    lines = chunk.split("\n");

    lines[0] = lingeringLine + lines[0];
    lingeringLine = lines.pop();

    lines.forEach(processLine);
});

process.stdin.on('end', function() {
    processLine(lingeringLine);
});
