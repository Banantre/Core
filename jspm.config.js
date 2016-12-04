SystemJS.config({
    paths: {
        "npm:": "jspm_packages/npm/",
        "github:": "jspm_packages/github/",
        "banantre-runtime-javascript/": "Source/Runtime.JavaScript/"
    },
    browserConfig: {
        "baseURL": "/"
    },
    devConfig: {
        "map": {
            "plugin-babel": "npm:systemjs-plugin-babel@0.0.12",
            "process": "npm:jspm-nodelibs-process@0.2.0",
            "core-js": "npm:core-js@1.2.7",
            "babel-runtime": "npm:babel-runtime@5.8.38",
            "path": "npm:jspm-nodelibs-path@0.2.0",
            "fs": "npm:jspm-nodelibs-fs@0.2.0"
        }
    },
    transpiler: "plugin-babel",
    packages: {
        "banantre-runtime-javascript": {
            "main": "Distribution/index.js",
            "meta": {
                "*.js": {
                    "loader": "plugin-babel"
                }
            }
        }
    },
    map: {
        "Distribution": "local:Distribution@master",
        "assert": "npm:jspm-nodelibs-assert@0.2.0",
        "buffer": "npm:jspm-nodelibs-buffer@0.2.0",
        "child_process": "npm:jspm-nodelibs-child_process@0.2.0",
        "util": "npm:jspm-nodelibs-util@0.2.0",
        "vm": "npm:jspm-nodelibs-vm@0.2.0"
    }
});

SystemJS.config({
    packageConfigPaths: [
        "npm:@*/*.json",
        "npm:*.json",
        "github:*/*.json"
    ],
    map: {},
    packages: {}
});