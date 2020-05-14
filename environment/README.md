# Environment (Underlying) Application Infrastructure

This holds the base infrastructure that is used by all microservices. It holds:
* App Mesh
* AWS Config, Logging
* Configuration
* Infrastructure Qualification Configuration

    .
    ├── deploy                 # Scripts to deploy the base infrastructure
    ├── infrastructure         # The actual base infrastructure
    ├── tests                  # The actual base infrastructure
    └── README.md