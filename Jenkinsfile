pipeline {
    agent any

    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = 'true'
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                script {
                    echo 'Restoring dependencies and building the .NET application...'
                    sh 'dotnet restore'
                    sh 'dotnet build'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                        echo 'Running unit tests...'
                        sh 'dotnet test'  // Run unit tests using the default test runner

                        echo 'Running integration tests...'
                        // Add commands to run integration tests (e.g., using a different test runner)

                        echo 'Running end-to-end tests...'
                        // Add commands to run end-to-end tests (e.g., using a different test runner)
                }
            }
        }


        stage('Publish') {
            steps {
                script {
                    echo 'Publishing the .NET application...'
                    sh 'dotnet publish -c Release -o ./publish'
                }
            }
        }

        stage('Deploy') {
            steps {
                script {
                    echo 'Deployment steps go here...'
                    // Add deployment commands here (e.g., copying files to a server)
                }
            }
        }
    }

    post {
        always {
            echo 'Cleaning up...'
            cleanWs()
        }
    }
}
