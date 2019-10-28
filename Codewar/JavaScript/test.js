function main() {
    const readline = require('readline')
    const problemParser = new ProblemParser()
  
    const rl = readline.createInterface({
      input: process.stdin,
      output: process.stdout
    })
  
    rl.on('line', (line) => {
      problemParser.readline(line)
  
      if (problemParser.isComplete()) {
        rl.close()
      }
    }).on('close', () => {
        processCases(problemParser.getCases())
      }
    )
  }
  
  if (!module.parent) {
    main()
  }