#!/usr/bin/env python
# -*- coding: utf-8 -*-

MYSQL_HOST = "localhost"
MYSQL_PORT = 3306
MYSQL_USER = "sgll"
MYSQL_PWD = "sgll"
MYSQL_DB = "sgll"

Config = {
    "mysql": {
        "connection": 'mysql://%s:%s@%s:%s/%s?charset=utf8' % (MYSQL_USER, MYSQL_PWD, MYSQL_HOST, MYSQL_PORT, MYSQL_DB)
    }
}
