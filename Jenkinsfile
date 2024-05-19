pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', credentialsId: 'github', url: GIT_URL
            }
        }

        
        stage('SonarQube Scan') {
            steps {
                withSonarQubeEnv(installationName: 'localSonar12',credentialsId: 'sonartoken') {
                    // This expands the evironment variables SONAR_CONFIG_NAME, SONAR_HOST_URL, SONAR_AUTH_TOKEN that can be used by any script.

                    bat '''echo The path variable is: %path%
                    dotnet sonarscanner begin /k:"com:calculator" /d:sonar.host.url=%SONAR_HOST_URL% /d:sonar.token=%SONAR_AUTH_TOKEN%
                    dotnet build . --no-incremental
                    dotnet sonarscanner end /d:sonar.token=%SONAR_AUTH_TOKEN%'''
                }    
            }
        }

        stage('Build Artifact'){
            steps{
                bat '''dotnet publish -r win-x64 --self-contained true'''
            }
        }
        stage('Archieve / Cleanup Workspace'){
            steps{
                archiveArtifacts artifacts: '**/*.exe', fingerprint: true, followSymlinks: false, onlyIfSuccessful: true
                cleanWs()
            }
        }
    }
}
