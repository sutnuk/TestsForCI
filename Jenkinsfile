pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat(script: '"C:\\Nuget\\nuget.exe" restore TestsForCI.sln', label: 'Restore nuget', returnStatus: true)
        bat(label: 'Build solution', returnStatus: true, script: '"C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\MSBuild.exe" TestsForCI.sln')
      }
    }

    stage('Test') {
      steps {
        bat(script: '"C:\\Program Files (x86)\\NUnit.org\\nunit-console\\nunit3-console.exe" TestsForCI\\bin\\Debug\\TestsForCI.exe', label: 'Start nunit', returnStatus: true)
      }
    }

    stage('Generate Reporting') {
      steps {
        cucumber(classificationsFilePattern: '**/*.json', fileExcludePattern: '0', reportTitle: 'Report', buildStatus: 'Builded', fileIncludePattern: 'File')
      }
    }

  }
}