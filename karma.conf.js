module.exports = function (config) {
    "use strict";
    config.set({
        basePath: "",
        autoWatch: true,
        singleRun: false,
        frameworks: ["jspm", "jasmine", "chai", "chai-as-promised"],
        files: [
            "config.js"
        ],
        jspm: {
            config: "config.js",
            defaultJSExtensions: true,
            packages: "jspm_packages/",
            loadFiles: [
                "Source/Runtime.JavaScript/**/*.js",
                "Source/Runtime.JavaScript.Specifications/**/given/*.js",
                "Source/Runtime.JavaScript.Specifications/**/*.js",
            ],
            serveFiles: [
                "jspm_packages/**/*.js"
            ]
        },
        
        preprocessors: {
            "Source/**/*.js": ['babel'],
        },        
        babelPreprocessor: {
            options: {
                presets: ["es2015"],
                sourceMap: "inline"
            }
        },
        
        proxies: {
            '/Source': '/base/Source'
        },
        
        port: 9876,
        
        browsers: ['PhantomJS'],
        reporters: ['progress']
    });
};