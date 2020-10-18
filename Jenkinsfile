pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat(script: '"C:\\Nuget\\nuget.exe" restore TestsForCI.sln', label: 'Restore nuget', returnStatus: true)
      }
    }

    stage('Test') {
      steps {
        bat 'test.script'
      }
    }

  }
}