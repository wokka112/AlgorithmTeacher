# Code of Conduct

Everyone contributing to this project follows a [code of conduct](CODE_OF_CONDUCT.md). When contributing to this project you are expected to uphold this code of 
conduct.

# Contributing

Thank you for taking an interest in contributing to this project. This is a simple project mainly started for the learning experience it could provide, so enjoy 
yourself as you contribute and maybe try and tackle a new algorithm you haven't used before.

## Bug reports

If you are reporting a new bug please create an issue for it. Before creating a new issue to report the bug first search the existing issues to ensure you aren't 
making a duplicate bug report. 

For new bugs, please use the following bug report template:

### Description

Give a full description here of the bug.

### Frequency

Note how frequently the bug occurs - everytime, most times, half the time, less than half the time, barely ever.

### How to recreate the bug

Give a step-by-step approach for recreating the bug.

### Other

Any other notes you might have on it.

## New algorithms or Features

The simplest way to add a new algorithm or feature is to create a pull request with the new algorithm or feature. In the pull request please explain what the 
algorithm is and what it solves, or in the case of a new feature, explain what it does and why you think it should be added.

When adding a new algorithm please create an algorithm class that inherits from the AlgorithmBase class and follow the example of other algorithms. Give the algorithm 
a name, a short introduction that summarises what the algorithm is, a description explaining how the algorithm works, and pseudocode for the algorithm. Then override 
the DisplayAlgorithmDefaultCase() method with your example of how the algorithm works in action. Please include in this display writelines to the console that explain
what is happening and what the results are to better help the user understand how the algorithm works.

If you are simply wanting to request an algorithm or  new feature please use the issues system. Search the issues first to ensure you aren't making a duplicate 
request, then feel free to post a new issue. There is currently no specific template for feature or algorithm requests, just give a good description that is more than 
a line. If it's a new algorithm, give us details on how it works or a link to further details on it. If it's a new feature, tell us why it would be useful.
