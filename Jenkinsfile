pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat 'build.script'
      }
    }

    stage('Test') {
      steps {
        bat 'test.script'
      }
    }

  }
}