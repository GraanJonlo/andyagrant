import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface VideoPostMatch {
    id: string;
}

type VideoPostProps = RouteComponentProps<VideoPostMatch>;

export class VideoPost extends React.Component<VideoPostProps, {}> {
    constructor(props: VideoPostProps) {
        super(props);
    }

    public render() {
        return <div>
                   <h1>Video</h1>

                   <p>This is a simple example of a React component.</p>

                   <p>{this.props.match.params.id}</p>
               </div>;
    }
}